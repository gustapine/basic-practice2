class Cidade
{
    //propriedades
    // visibilidade tipo nome
    public string nome;
    public int populacao;
    public float area;
    public string estado;
    

    //métodos

    //método construtor
    //visibilidade nomeClasse (parametros(pode ser o nome que ce quiser))
    public Cidade(){
        this.nome = "";
        this.estado = "";
        this.populacao = 0;
        this.area = 0;
        
    }

    public Cidade(string n, string e, int p, float a){
        this.nome = n;
        this.estado = e;
        this.populacao = p;
        this.area = a;
    }

    // visibilidade tipoRetorno nome(parametros)
    public string mostrarDados(){  //assinatura do método
       
        string mensagem;

        mensagem = "A cidade de " + this.nome + " fica no estado de " + this.estado +
        ". Possui uma população de " + this.populacao + 
        " habitantes, distribuídos por  uma área de " +
        this.area + " km²";

        return mensagem;
    }
    
    public string mostrarDados(string oque){
        /*  T- tudo,
            H - adiciona habitantes
            A - adiciona área 
            D - adiciona habitantes por area  */

        string mensagem="";

        mensagem += "A cidade " + this.nome + 
        " que fica no estado"+ this.estado;
        
        if(oque== "T" || oque=="H"){
            mensagem += " possui" + 
                Convert.ToString(this.populacao) + " habitantes"; 

        }
        
        if(oque== "T" || oque=="A"){
            mensagem += " possui uma área de " + 
                Convert.ToString(this.area) + " km²";
        }

        if(oque== "T" || oque=="D"){
            mensagem += ", possui uma densidade de " + 
                Convert.ToString(this.populacao/this.area) + " habitantes por km²";
        }

        mensagem += "." ;
        return mensagem;
    }
}