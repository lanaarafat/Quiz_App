using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz_App;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class QuizTests
    {
        [TestMethod]
        public void LoadQuestions_ShouldLoadQuestions()
        {
            // Arrange
            var quizForm = new QuizForm();

            // Act
            quizForm.LoadQuestions();

            // Assert
            Assert.AreEqual(2, quizForm.Questions.Count);

        [TestMethod]
        public void CheckAnswer_ShouldIncreaseScoreForCorrectAnswer()
        {
            // Arrange
            var quizForm = new QuizForm();
            quizForm.LoadQuestions();
            quizForm.SelectedAnswer = 1;
            quizForm.CorrectAnswer = 1;

            // Act
            quizForm.CheckAnswer();

            // Assert
            Assert.AreEqual(1, quizForm.Score);
        }

        [TestMethod]
        public void CheckAnswer_ShouldNotIncreaseScoreForIncorrectAnswer()
        {
            // Arrange
            var quizForm = new QuizForm();
            quizForm.LoadQuestions();
            quizForm.SelectedAnswer = 0;
            quizForm.CorrectAnswer = 1;

            // Act
            quizForm.CheckAnswer();

            // Assert
            Assert.AreEqual(0, quizForm.Score);
        }
    }
}
}