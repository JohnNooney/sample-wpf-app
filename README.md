# sample-wpf-app
A C# WPF MVVM application that integrates with a SQLite database. 


This is a WPF application with MVVM design pattern that serves as a catalogue for different shapes. Users can create new shapes
through an editor and add them to the catalogue. A list view displays all the shapes, and a preview area shows the details of the selected shape.

### Technologies Used

* C#
* WPF
* MVVM
* EntityFramework
* SQLite
* Docker

### Getting Started

1. Clone this repository.
1. Start the SQLite database with `docker-compose up -d --build` in the root directory.
2. Open the solution file (`SampleApplication.sln`) in Visual Studio.
3. Ensure you have the necessary development tools for WPF applications.
4. Run the application (press F5) to launch the Application.

###  Application Functionality

The application consists of two main views:

* **Shape Editor:** This view allows you to define properties for a new shape:
    * **Shape Type:** Choose between Square and Rectangle from a dropdown menu.
    * **Width:** Enter the desired width of the shape.
    * **Height:** Enter the desired height of the shape (applicable only to rectangles).
    * **Color:** Select a color for the shape using a color picker.
    * **Add Button:** Click this button to add the newly defined shape to the catalogue.
* **Shape List & Preview:** 
    * A list view displays all the shapes currently in the catalogue. Each entry shows the shape type and its dimensions.
    * Selecting a shape from the list populates the preview area on the right side. This area displays a larger representation of the chosen shape along with its details.

###  Code Structure

The solution is organized into the following main folders:

* **Models:** Contains definition of the Shape base class and derived classes for specific shapes (Square and Rectangle).
* **ViewModels:** Holds view models for each view (ShapeEditorViewModel, ShapeListViewModel).
* **Views:** Contains the WPF UI files (ShapeEditor.xaml, ShapeList.xaml, MainWindow.xaml).

###  Key Features

*  Create new squares and rectangles with defined width, height, and color.
*  Add new shapes to the catalogue.
*  View a list of all shapes in the catalogue.
*  Select a shape from the list to see its details and preview.