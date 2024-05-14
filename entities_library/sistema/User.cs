namespace entities_library.sistema;

public class User{ //Creacion de una clase publica, llamda "User"  
    private long id;  //atributo privado de la clase
    public void SetId(long id){
        this.id= id;
    }    
    public long GetId(){
        return this.id;
    }

    public long id{
        get (return this.id;)
        set (this.id = ValueTask;)
    }
    public string UserName 
    {
        get;
        set;
    }

    public string Apellido
    {
        get;
        set;
    }

    public string GetFullName()
    {
        return this.Nombre + " " + this.Apellido
    }
}
