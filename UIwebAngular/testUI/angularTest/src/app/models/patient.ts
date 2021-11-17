export interface patient{
    Id : string;
    Name: string;
    Sirname: string;
    Age: number;
    IdentityNo: number;
    Telephone: number;
    Address: string;
  }




  export interface SearchResults {
    total: number;
    results: Array<object>;
  }