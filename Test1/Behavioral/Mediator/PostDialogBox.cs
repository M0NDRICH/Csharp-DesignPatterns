using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    // Concrete Mediator
    public class PostDialogBox : DialogBox
    {
        // fields for all ui components
        private ListBox _postsListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public PostDialogBox()
        {
            _postsListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
            _saveButton.SetEnabled(false);
        }

        public void SimulateUserInteraction()
        {
            _postsListBox.SetSelection("Post 2");
            //_titleTextBox.SetText("");
            Console.WriteLine("Title text box: " + _titleTextBox.GetText());
            Console.WriteLine("Button enabled: " + _saveButton.isEnabled());
        }

        public override void Changed(UIControl uiControl)
        {
            if (uiControl == _postsListBox)
            {
                HandlePostChanged();
            } 
            else if (uiControl == _titleTextBox)
            {
                HandleTitleChanged();
            }
        }

        private void HandlePostChanged()
        {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }

        private void HandleTitleChanged()
        {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
            _saveButton.SetEnabled(!isTitleEmpty);
        }
    }
}
