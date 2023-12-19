// Clases concretas Command
public class ApagarDispositivoCommand : ICommand
{
    private Dispositivo dispositivo;

    public ApagarDispositivoCommand(Dispositivo dispositivo)
    {
        this.dispositivo = dispositivo;
    }

    public void Execute()
    {
        dispositivo.Apagar();
    }
}



