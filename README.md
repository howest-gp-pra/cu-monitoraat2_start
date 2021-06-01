# Monitoraat 02/06/2021

De bedoeling van deze monitoraatsessie is om nog eens een volledig voorbeeld uit te werken rond de belangrijkste zaken die we behandeld hebben in onze cursussen PRB en PRA : 
  * Entiteitsklassen  (& objecten)
  * Serviceklassen  (& collections)
  * Overerving 
  * Interfaces
  * Compositie  
  
Naast deze belangrijke concepten halen we - waar mogelijk - ook nog een aantal bijkomende zaken/technieken aan (denk aan nullables, short hand if, string extrapolatie ...)

Het is niet de bedoeling van deze monitoraatsessie dat jullie zelf tijdens de sessie gaan programmeren : jullie volgen gewoon op het scherm mee hoe ik stap voor stap tot een oplossing ga komen.  
Uiteraard kan je achteraf alles zelf nog eens uitproberen door deze repo binnen te halen.
De volledige oplossing van dit projectje kan je dan weer hier terugvinden : https://github.com/howest-gp-pra/cu-monitoraat2 

Wanneer je de starterscode binnenhaalt zal je merken dat er heel wat in zit.

### De class library 

In de class library zijn 4 mappen aanwezig : 
  * Enums  
    In deze map zit 1 bestand met de naam Enums.cs.  
    In het bestand zelf zal je 3 publieke enumeraties terugvinden :   
      * AddressType : 4 verschillende soorten adrestypes  
      * Function : 4 verschillende soorten functies  
      * Diploma : 8 verschillende soorten diploma's  
    Deze enumeraties zullen op verschillende plaatsen in je programma gebruikt worden.
  * Interfaces  
    In deze map zitten 4 bestanden : 
      * IPerson.cs : deze interface beschrijft 8 eigenschappen en 1 methode.  Deze zal straks geïmplementeerd worden door de entiteitsklasse Person (zie verder)   
      * IStaff.cs : deze interface beschrijft 2 eigenschappen en zal straks geïmplementeerd worden door de entiteitsklasse Staff (zie verder)  
      * IStudent.cs : deze interface beschrijft 1 eigenschap en zal straks geïmplementeerd worden door de entiteitsklasse Student (zie verder)
      * IPersonService : deze interface beschrijft 1 (read only) eigenschap en 2 methoden en zal straks geïmplementeerd worden door de service klasse PersonService (zie verder)
  * Entities   
    In deze map zitten 4 bestanden (entiteitsklassen) (die nog volledig dienen ingevuld te worden) :   
    * Address   
      Deze klasse beschrijft een adres en dient volgende members te krijgen :   
        * Eigenschappen (eenvoudige props, geen controle vereist) :   
          * prop Street (string)  
          * prop HouseNumber (string)  
          * prop PostalCode (string)  
          * City (string)  
          * AddressType (enumeratietype AddressType)
        * 1 constructor die evenveel waarden als props ontvangt  
        * Overschrijft de ToString en toont  adrestype : straat, huisnummer - postocde gemeente - land
  * Person  
    Dit is een basisklasse waarvan geen instanties van mogen gemaakt worden.  
    De klasse implementeert de IPerson interface.  Je maakt de props aan zoals de Interface opgeeft.  
    Bijkomende info : 
      * Indien geen naam meegegeven wordt dient een fout opgegooid te worden.  
      * Indien de geboortedatum kleiner is dan 1/1/1920 wordt deze automatisch aangepast naar 1/1/1920.  Is de opgegeven waarde groter dan vandaag, dan wordt deze automatisch aangepast naar vandaag.    
      * De eigenschap AgenInYears (leeftijd uitgedrukt in jaren) is readonly en is het resultaat van een berekening op basis van de geboortedatum.  
      * Een persoon kan meerdere e-mail adressen hebben : deze worden bijgehouden als een List van strings (= compositie).
      * Een persoon kan meerdere adressen hebben : deze worden bijgehouden als een List van Address objecten (= compositie).
    
  * 
