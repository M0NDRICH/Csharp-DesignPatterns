using DesignPatterns.Behavioral.Mediator.MediatorWithObserver.UIFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator.MediatorWithObserver
{
    // Mediator & Observer
    public class PostsDialogBox
    {
        // declare fields for UI components
        private UIFramework.ListBox _postsListBox;
        private UIFramework.TextBox _titleTextBox;
        private UIFramework.Button _saveButton;

        public PostsDialogBox()
        {
            _postsListBox = new UIFramework.ListBox();
            _titleTextBox = new UIFramework.TextBox();
            _saveButton = new UIFramework.Button();

            _postsListBox.AddEventHandler(PostSelected);
            _titleTextBox.AddEventHandler(TitleChanged);
        }

        public void SimulateUserInteraction()
        {
            _postsListBox.SetSelection("Post 2");
            //_titleTextBox.SetText("");
            Console.WriteLine("Title text box: " + _titleTextBox.GetText());
            Console.WriteLine("Button enabled: " + _saveButton.isEnabled());
        }

        private void PostSelected()
        {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }

        private void TitleChanged()
        {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
            _saveButton.SetEnabled(!isTitleEmpty);
        }
    }
}
