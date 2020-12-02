using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuizApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int currentQuestion = 1;
        int choiceTrue = 0;
        int choiceFalse = 0;
        public void OnButtonClicked(object sender, EventArgs args)
        {
            
            currentQuestion++;
            if (sender.Equals(TrueButton))
            {
                choiceTrue++;
            }
            else
            {
                choiceFalse++;
            }
            
            changeQuestionNumber();

            changeQuestionContent();
        }
        void changeQuestionNumber()
        {
            //change question number
            if (currentQuestion == 2)
            {
                QuestionNumber.Text = "Question Two";

            }
            else if (currentQuestion == 3)
            {
                QuestionNumber.Text = "Question Three";

            }
            else if (currentQuestion == 4)
            {
                QuestionNumber.Text = "Question Four";

            }
            else if (currentQuestion == 5)
            {
                QuestionNumber.Text = "Question Five";

            }
            else
            {
                QuestionNumber.Text = "Results";
            }
        }
        void changeQuestionContent()
        {
            if (currentQuestion == 2)
            {
                QuestionContent.Text = "Do you feel energized when your around other people?";
            }
            else if(currentQuestion == 3)
            {
                QuestionContent.Text = "Do you normally go out of your way to talk to others?";
            }
            else if(currentQuestion == 4)
            {
                QuestionContent.Text = "Do you like to be the center of attention?";
            }
            else if(currentQuestion == 5)
            {
                QuestionContent.Text = "Are you the person in the friend group who is always trying to get people to go out with you?";
            }
            else
            {
                if(choiceTrue > 3)
                {
                    QuestionContent.Text = "You are an Extrovert";
                }
                else
                {
                    QuestionContent.Text = "You are an Introvert";
                }
                
                TrueButton.IsVisible = false;
                FalseButton.IsVisible = false;
            }
        }
    }
}
