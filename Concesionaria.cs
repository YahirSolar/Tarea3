namespace Tarea3;

class Concesionaria {
    public List<Automovil> Autos;
    public int limite;
    public int actual;

    public Concesionaria(int limite) {
        Autos = new List<Automovil>();
        this.limite = limite;
        this.actual = 0;
    }
    public void AgregarAuto(Automovil auto) {
        if(auto != null && actual < limite){
            Automovil? autoEncontrado = Autos.Find((autoL) => autoL.placa == auto.placa);
            if(autoEncontrado != null){
                Autos.Add(auto);
                actual += 1;
            }else{
                Console.WriteLine("\nNo ingresaste un auto\n");
            }   
        }else{
            Console.WriteLine("\nNo hay mas espacio en la Concesionaria\n");
        }
    }
    public void MostrarAuto(string placa) {

        Automovil? autoEncontrado = Autos.Find((autoL) => autoL.placa == placa);
        if(autoEncontrado != null) {
            Console.WriteLine(autoEncontrado.ToString());
        }else{
            Console.WriteLine("\nEl auto que buscas no está en el Concesionario\n"); 
        }
        
    }
    public void EliminarAuto(string placa) {
        if(placa != "" && actual != 0){
            Automovil? autoEncontrado = Autos.Find((autoL) => autoL.placa == placa);
            if(autoEncontrado != null){
                Autos.Remove(autoEncontrado);
                actual -= 1;
            }    
        }else{
            Console.WriteLine("\nNo hay autos que eliminar de la Concesionaria\n");
        }
    }
    public void MostrarAutos() {
        Console.WriteLine("\nAutos de la Concecionaria SamuPelonSA\n");
        foreach(Automovil item in Autos){
            Console.WriteLine(item);
        }
    }
    public void VaciarConcesionario() {
        Autos.Clear();
        Console.WriteLine("\nLa Concesionaria está vacia se los robo el samu pelon\n");
    }
}