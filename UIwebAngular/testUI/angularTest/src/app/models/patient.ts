export interface patient{
    Id : string;
    Name: string;
    Sirname: string;
    Age: number;
    IdentityNo: BigInt;
    Telephone: BigInt;
    Address: string;
  }

  export interface SearchResults {
    total: number;
    results: Array<object>;
  }