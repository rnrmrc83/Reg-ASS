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

La percentuale di sconto che un fornitore potrebbe offrire può essere correlata:
- al valore totale dell'ordine --> CONDZIONE IMPORTO RAGGIUNTO (VAL)
- alla quantità ordinata  --> CONDIZIONE QTA DA ORDINARE (NR)
- potrebbe essere limitata a una data/stagione particolare --> CINZIONE SCONTO VALIDO NEL PERIODO DI ORDINE (TIME)

Per gestire le varie tipologie di sconti (NR, VAL, TIME) La tabella PriceList si compone di campi:


IdProduct | IdDiscountType | LowLimit | HighLimit | ValueLimit | Discount% | StartDate |   EndDate |     Discontinued

A202CF3   | NR  |  10   |  20     |   0.00   |   1.00  |   01/01/2022 | 31/12/2099 | 0  

(sc del prezzo di listino del 1% per QTA TRA 10<=x<=20 )

A202CF3   | NR  |  21   |  99999  |  0.00    |   3.00  |   01/01/2022 | 31/12/2099 | 0 
(sc del prezzo di listino del 1% per QTA TRA 21<=x<=999999 )

A202CF3   | VAL |  NULL |  NULL   |   1000.00|   5.00  |   01/03/2022 | 08/03/2022 | 0 
(sc del 5% sul totale nella data di validità)

UZ456HGT  | TIME|  NULL |  NULL   |   0.00   |   2.00  |   01/09/2022 | 30/09/2022 | 0   
(sc del 2% a settembre)

Quando devi ordinare un articolo, scegli un articolo e la quantità che desideri acquistare; il sistema:

- Filtra prodotti con disponibilita >= all qta richiesta
- Individua sconto NR
- Individua e applica sconto Valore sul TOT
- Individia e applica sconto extra 
- Visualizza l'elenco dei risultati ordinando per il prezzo migliore.

