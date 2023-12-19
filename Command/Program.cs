class Program
{
    static void Main()
    {
        // Crear instancias de Receiver y Command
        Dispositivo dispositivo = new Dispositivo();
        ICommand encenderCommand = new EncenderDispositivoCommand(dispositivo);
        ICommand apagarCommand = new ApagarDispositivoCommand(dispositivo);

        // Crear instancia de ControlRemoto y configurar con los comandos
        ControlRemoto remote = new ControlRemoto(encenderCommand, apagarCommand);

        // Utilizar el control remoto para encender y apagar el dispositivo
        remote.EncenderDispositivo();
        remote.ApagarDispositivo();
    }
}