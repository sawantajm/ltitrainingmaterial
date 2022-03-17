import { HttpClient } from "@angular/common/http";
import {  Injectable } from "@angular/core";


@Injectable()

 export class productService
{
    private readonly url="https://jsonplaceholder.typicode.com/posts";
     constructor(private http:HttpClient)
    {
      
            
                
    }

    togetdata()
   {
         return this.http.get(this.url);

         console.log("fetching data from url");

    }


}

