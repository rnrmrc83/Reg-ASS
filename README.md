# Regesta
PurchaseOrderReg


PROBLEMA
Implementazione di un Il tuo negozio vende beni che puoi acquistare da diversi fornitori. Il prezzo di vendita di ogni articolo è fisso, ma l'articolo può essere acquistato da diversi fornitori a differente prezzo/sconto.

ARCHITETTURA
Applicazione "embionale" .NET/C# WebForm + DB MSSQL 

DATABASE PurchaseOReg.bak (contiene dati di test)
Sono state implentate per semplicta solamente le seguenti tabelle:

- Product: Prodotti a catalogo forniti da n fornitori (FK) dove per ogni prodotto appartenente ad una categoria (FK) vi è il prezzo di listino (Prezzo unitario) 
- ProductCategory: Tabella per classificare tipologie di prodotti
- Supplier: Catalogo Fornitori
- PriceList: Tabella contenete le condizioni di vendita o scontistiche per determinati prodotti

La percentuale di sconto che un fornitore potrebbe offrire può essere correlata :
- al valore totale dell'ordine --> CINDZIONE IMPORTO RAGGIUNTO
- alla quantità ordinata  --> CONDIZIONE QTA DA ORDINARE
- potrebbe essere limitata a una data/stagione particolare --> CINZIONE SCONTO VALIDO NEL PERIODO DI ORDINE




Quando devi ordinare un articolo, scegli un articolo e la quantità che desideri acquistare; il sistema dovrebbe trovare quali fornitori vendono quell'articolo (verificare se è disponibile una quantità sufficiente in magazzino) e calcolare l'importo totale dell'ordine di acquisto applicando gli sconti (se disponibili). L'elenco dei risultati dovrebbe suggerire il miglior fornitore evidenziando quello più economico.

Visualizza anche i giorni minimi necessari a ciascun fornitore per spedire il tuo ordine; in questo modo puoi scegliere che un fornitore più veloce sia comunque migliore di uno più economico.
