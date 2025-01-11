# Bussiness Manager

## Overview
Bussiness Manager is a desktop application developed in C# using Visual Studio. It is designed to streamline and manage various business operations, such as contractor management, customer service, road services, sales, and worker administration. The application includes features for data handling and provides an intuitive interface for managing business workflows.

## Features
- **Contractor Management**: Keep track of contractors and their services.
- **Customer Service Management**: Handle customer-related data efficiently.
- **Road Services Tracking**: Manage and monitor road services.
- **Sales Management**: Track and manage sales activities.
- **Worker Administration**: Manage worker details and assignments.

## Project Structure
```
Bussiness Manager/
├── Backend/
│   └── Model/
│       ├── BussinesManager.cs
│       ├── Contractors.cs
│       ├── CustomerService.cs
│       ├── Roadservices.cs
│       ├── SalesMen.cs
│       ├── TowingServices.cs
│       └── Workers.cs
├── bin/
├── Properties/
├── App.config
├── MainForm.cs
├── Form1.cs
├── DataDataSet.xsd
└── Program.cs
```

## Requirements
- **Operating System**: Windows 10 or later
- **Framework**: .NET Framework 4.7.2 or higher
- **Development Environment**: Visual Studio 2019 or later
- **Database**: SQL Server (integrated with application)

## Installation
1. Clone the repository:
   ```bash
   git clone <repository_url>
   ```
2. Open the project in Visual Studio:
   - Navigate to `Bussiness Manager.sln` and open it in Visual Studio.
3. Build the solution:
   - Click on `Build` > `Build Solution` or press `Ctrl+Shift+B`.
4. Set up the database:
   - The `Data.mdf` file is included in the project. Ensure SQL Server is installed and configured to use the `.mdf` file.
5. Run the application:
   - Press `F5` or click on `Debug` > `Start Debugging`.

## Usage
1. Launch the application.
2. Navigate through the menu to manage different business modules:
   - **Contractors**: Add, edit, or remove contractor details.
   - **Customer Service**: Manage customer information.
   - **Road Services**: Track road service activities.
   - **Sales**: Manage and analyze sales data.
   - **Workers**: Administer worker profiles and assignments.

## Database Structure
The application uses a SQL Server database. Key tables include:
- **Contractors**: Contains contractor details.
- **Customers**: Stores customer data.
- **Sales**: Tracks sales records.
- **Workers**: Manages worker details.

## Contributing
Contributions are welcome! If you wish to contribute:
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Description of changes"
   ```
4. Push the changes:
   ```bash
   git push origin feature-name
   ```
5. Submit a pull request.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.

## Contact
For any queries or issues, please contact [monayer42@gmail.com].

