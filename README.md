# Blizzy's Contact Compiler:

A simple desktop application built with C# and Windows Forms that allows users to collect contact information (name, address, phone number, email) and export it to an Excel spreadsheet. The application lets users continually add contacts and then generate a spreadsheet file with the collected data. It also offers the option to sort the contacts alphabetically by name.

## Features
- Collect contact information including:
  - Name
  - Street Address
  - City
  - State Abbreviation
  - Zip Code
  - Phone Number
  - Email
- Display the list of added contacts in a ListView or DataGridView.
- Export contact data to an Excel spreadsheet using the EPPlus library.
- Option to sort contacts alphabetically by name before exporting.
- User-friendly interface with input validation and error handling.

## Prerequisites
- Visual Studio (Community, Professional, or Enterprise edition)
- .NET Framework (for Windows Forms App) or .NET Core (for WPF App)
- EPPlus NuGet package for Excel file generation

## Setup Instructions

1. **Clone the Repository**
   ```bash
   git clone https://github.com/caisonlewis/Contact-Compiler.git
