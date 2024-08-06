namespace CommandDP.Models
{
    //class to turn on the television
    internal class OnCommand : ICommand
    {
        //referece to the television object
        private Television _television;

        //constructor to initialize the television object
        public OnCommand(Television television)
        {
            _television = television;
        }

        //execute method to turn on the television
        public void Execute()
        {
            //calls the on method of televsion object
            _television.On();
        }

    }
}
