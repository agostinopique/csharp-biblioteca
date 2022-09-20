// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

#region Insructions

//Esercizio:

//Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
//cognome,
//nome,
//email,
//password,
//recapito telefonico,

//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).

//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

#endregion Instructions

#region User


Console.WriteLine("Registrati inserendo il tuo nome");
string userName = Console.ReadLine();

Console.WriteLine("Inserisci il cognome");
string userSurname = Console.ReadLine();

Console.WriteLine("Inserisci il tuo indirizzo email");
string userEmail = Console.ReadLine();

Console.WriteLine("Inserisci il tuo numero di telefono");
string userNumber = Console.ReadLine();

Console.WriteLine("Inserisci la tua passsword");
string userPassword = Console.ReadLine();

//List<object> users = new List<object> { };

User newUser = new User();

newUser.Name = userName;
newUser.Surname = userSurname;
newUser.Email = userEmail;
newUser.Password = userPassword;
newUser.PhoneNumber = userNumber;

//users.Add(newUser);

public class User
{
    //protected string surname;
    //protected string name;
    //protected string email;
    //protected string password;
    //protected string phoneNumber;

    public string Name { get; set; }
    public string Surname { set; get; }
    public string Email { set; get; }
    public string Password { set; get; }
    public string PhoneNumber { set; get; }

}

#endregion USer

#region Library



#endregion Library
