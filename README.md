# Contact Management Web Application
## Overview

This .NET web application allows users to upload CSV files containing data with the following fields:

- Name [string]
- Date of Birth [date]
- Married [bool]
- Phone [string]
- Salary [decimal]

The application processes the CSV file, stores the data in an MS SQL database, and displays the stored data on a web page. Users can filter and sort the data by any column on the client side using JavaScript. Additionally, the application supports inline editing and the ability to remove records from the database.

## Features
- CSV Upload: Upload CSV files and process them.
- Data Storage: Store CSV data in an MS SQL database.
- Data Display: View stored data in a tabular format.
- Filtering and Sorting: Filter and sort data by any column on the client side.
- Inline Editing: Edit records directly within the table.
- Record Removal: Delete records from the database.
