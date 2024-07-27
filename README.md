# Quiz Application

## Overview

This project is a Windows Forms-based quiz application developed using C#. The application allows users to take multiple-choice quizzes on various topics, providing immediate feedback on their answers and displaying the final score at the end. Users can retake the quiz if desired.

## Features

- Interactive user interface with Windows Forms.
- Multiple-choice questions with images.
- Immediate feedback on whether the selected answer is correct or incorrect.
- Tracking of the user's score throughout the quiz.
- Display of the user's final score and percentage.
- Option to retake the quiz.

## Requirements

- .NET Framework 4.0 or higher.
- Visual Studio (recommended for development).

## Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/lanaarafat/Quiz_App.git
   ```
2. Open the solution file (`Quiz_App.sln`) in Visual Studio.

## Project Structure

- **Form1.cs**: Handles the main form that lists available quizzes and initiates the quiz form.
- **QuizForm.cs**: Manages the quiz functionality, including loading questions, displaying questions, confirming answers, and showing results.

## Usage

### Running the Application

1. Open the solution in Visual Studio.
2. Build the solution (`Build > Build Solution`).
3. Run the application (`Debug > Start Debugging`).

### Taking a Quiz

1. On the main form (`Form1`), click on any of the picture boxes to start the quiz.
2. The quiz form (`QuizForm`) will open, displaying the first question and its options.
3. Select an answer by clicking on one of the buttons.
4. Click the **Confirm** button to submit your answer and see immediate feedback.
5. The next question will be displayed automatically.
6. After completing all questions, your score and percentage will be displayed. You can choose to retake the quiz.

## Test-Driven Development

The project follows Test-Driven Development (TDD) principles to ensure code robustness and correctness. Unit tests are provided to verify the functionality of loading questions, checking answers, and calculating scores.