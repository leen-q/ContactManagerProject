$(document).ready(function () {
    $('#userTable').DataTable();

    $('.save-btn').click(function () {
        var row = $(this).closest('tr');
        var id = row.data('id');
        var user = {
            Id: id,
            Name: row.find('td:eq(0)').text(),
            DateOfBirth: row.find('td:eq(1)').text(),
            Married: row.find('td:eq(2)').text() === 'True',
            Phone: row.find('td:eq(3)').text(),
            Salary: parseFloat(row.find('td:eq(4)').text())
        };

        $.ajax({
            type: 'POST',
            url: '/Users/Edit',
            data: JSON.stringify(user),
            contentType: 'application/json',
            success: function () {
                alert('Record updated');
            },
            error: function () {
                alert('Error updating record');
            }
        });
    });

    $('.delete-btn').click(function () {
        if (confirm('Are you sure you want to delete this record?')) {
            var row = $(this).closest('tr');
            var id = row.data('id');

            $.ajax({
                type: 'POST',
                url: '/Users/Delete',
                data: { id: id },
                success: function () {
                    row.remove();
                    alert('Record deleted');
                },
                error: function () {
                    alert('Error deleting record');
                }
            });
        }
    });
});
