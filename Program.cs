using CommandDP.Models;

namespace CommandDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television();

            ICommand onCommand = new OnCommand(television);
            ICommand offCommand = new OffCommand(television);

            RemoteControl remoteControl = new RemoteControl(onCommand);

            remoteControl.PressButton();
            remoteControl.SetCommand(offCommand);

            remoteControl.PressButton();
        }
    }
}
