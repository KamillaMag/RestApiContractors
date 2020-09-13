# RestApiContractors
REST API created with ASP.NET Core and LiteDB for contractors data manipulation  
### API Methods 
 - getting a list of contractors.  
 - adding a contractor.  
 ### UI
 Added [SwaggerUI](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) for comfortable test of API.  
 ### Database  
 [LiteDB](https://www.litedb.org/) is a serverless database delivered in a single small DLL fully written in .NET C# managed code.  
 DB file located in directory RestApiContractors/LiteDb. DB is filled with 4 demo records of contractors.  
 Contractor contains the following attributes:  
 - id: int  
 - name: string    
 - fullname: string  
 - type: enum (LegalEntity(Юр.лицо), IndividualEntrepreneur(ИП))  
 - inn: string  
 - kpp: string  
