namespace CommandDP.Models
{
    //class to turn off te television
    internal class OffCommand : ICommand
    {
        //reference to the television object
        private Television _television;

        //constructor to initialize the television object   
        public OffCommand(Television television)
        {
            _television = television;
        }

        //execute method to turn off the television
        public void Execute()
        {
            //calls the off method of television object
            _television.Off();
        }
    }
}
