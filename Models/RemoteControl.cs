namespace CommandDP.Models
{
    internal class RemoteControl
    {
        private ICommand _command;

        public RemoteControl(ICommand command)
        {
            _command = command;
        }

        //method to execute the current command
        public void PressButton()
        {
            _command.Execute();
        }

        //setter method to change the command at runtime
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
    }
}
