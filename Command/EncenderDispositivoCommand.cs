// Clases concretas Command
public class EncenderDispositivoCommand : ICommand
{
    private Dispositivo dispositivo;

    public EncenderDispositivoCommand(Dispositivo dispositivo)
    {
        this.dispositivo = dispositivo;
    }

    public void Execute()
    {
        dispositivo.Encender();
    }
}

