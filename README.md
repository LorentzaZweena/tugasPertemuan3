# Seminar Registration Application

A Windows Forms application developed using **Visual Studio 2022** and **VB.NET**. This project is a practical implementation of a **Multiple Windows Application** using various Command Controls provided in Windows Forms.

The application is designed as a simple **Seminar Registration System**, where users can enter participant information, select seminar details, and view the registration summary.

## 📌 Project Overview

This project consists of four main forms:

1. **Main Menu** – Provides navigation to the participant data, seminar data, and registration summary.
2. **Participant Data** – Allows users to enter participant information.
3. **Seminar Data** – Allows users to select seminar information and add additional notes.
4. **Registration Summary** – Displays all submitted participant and seminar information.

The application also demonstrates how data can be temporarily stored and passed between multiple forms.

## 🛠️ Technologies Used

- Visual Studio 2022
- Visual Basic .NET
- Windows Forms
- .NET Framework

## 🎛️ Controls Used

The project implements the 17 Command Controls required in the practical assignment:

- Button
- Label
- TextBox
- CheckBox
- RadioButton
- ListBox
- ComboBox
- PictureBox
- ProgressBar
- DateTimePicker
- ListView
- TreeView
- RichTextBox
- MaskedTextBox
- NumericUpDown
- LinkLabel
- TextBox (Multiline)

## 🖥️ Application Flow

```text
Main Menu
    │
    ├── Participant Data
    │       │
    │       └── Save Participant Data
    │
    └── Seminar Data
            │
            └── Save Seminar Data
                    │
                    ▼
             Registration Summary
````

## Features

### 1. Main Menu

Provides navigation between the different application forms.

### 2. Participant Registration

Users can enter:

* Name
* Email
* Phone Number
* Gender
* Address
* Age
* Study Program
* Seminar Attendance Confirmation

### 3. Seminar Information

Users can select:

* Seminar Date
* Seminar Field
* Participant Type
* Seminar Category
* Additional Notes

### 4. Registration Summary

Displays the participant and seminar information that has been entered.

The summary form also includes:

* Registration progress indicator
* PictureBox for an image
* Multiline TextBox for displaying the registration details

## 📂 Project Structure

```text
AplikasiPendaftaranSeminar/
│
├── Form1.vb
├── Form2.vb
├── Form3.vb
├── Form4.vb
├── DataPendaftaran.vb
│
└── AplikasiPendaftaranSeminar.sln
```

### Form Descriptions

| Form            | Description            |
| --------------- | ---------------------- |
| Form1           | Main Menu              |
| Form2           | Participant Data       |
| Form3           | Seminar Data           |
| Form4           | Registration Summary   |
| DataPendaftaran | Temporary data storage |

## 🚀 How to Run

1. Clone or download this repository.
2. Open the project using **Visual Studio 2022**.
3. Open the `.sln` solution file.
4. Make sure the project uses the required **.NET Framework** Windows Forms template.
5. Press **F5** or click **Start**.
6. Start the registration process from the Main Menu.

## 📚 Purpose

This project was created as a practical assignment for learning:

* Windows Forms development
* Visual Basic .NET
* Multiple Windows Applications
* Command Controls
* Event handling
* Temporary data storage
* Data transfer between forms
* Basic user interface design

## 👩‍💻 Author

**Ariva Zweena**

Student – Informatics Engineering
