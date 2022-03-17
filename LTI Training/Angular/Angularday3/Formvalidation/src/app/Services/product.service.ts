import { Injectable } from '@angular/core';
import { productdetails } from '../Model/Product.model';
//decorator
@Injectable({
  providedIn: 'root'
})
export class productService {
  product:productdetails[];

  constructor() { 
    this.product=[{pid:101,pname:"bag-model1",price:1200,quantity:10,image:"assets/images/bag1.jfif"},
    {pid:102,pname:"bag-model2",price:1000,quantity:20,image:"assets/images/bag1.jfif"},
    {pid:101,pname:"bag-model1",price:2000,quantity:10,image:"assets/images/bag1.jfif"}]
  }


  //fetch details

   getproductFromService()
   {
     return this.product;
   }

   addproductinservice(prod:productdetails)
   {
        this.product.push(prod);
   }
}