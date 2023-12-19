//Command
public class ControlRemoto
{
    private ICommand encenderCommand;
    private ICommand apagarCommand;

    public ControlRemoto(ICommand encenderCommand, ICommand apagarCommand)
    {
        this.encenderCommand = encenderCommand;
        this.apagarCommand = apagarCommand;
    }

    public void EncenderDispositivo()
    {
        encenderCommand.Execute();
    }

    public void ApagarDispositivo()
    {
        apagarCommand.Execute();
    }
}
