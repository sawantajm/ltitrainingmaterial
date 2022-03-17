import { Component, OnInit } from '@angular/core';
import { ProductDetails } from './producdetails';


@Component({
  selector: 'app-productdetails',
  templateUrl: './productdetails.component.html',
  styleUrls: ['./productdetails.component.css']
})
export class ProductdetailsComponent implements OnInit {

  constructor() { }

  product:ProductDetails[]=[
    {prod_id:1,productName:"chai",productPrice:100},
    {prod_id:2,productName:"Ipoh Coffee",productPrice:200},
    {prod_id:3,productName:"Gula Malacca",productPrice:500},
    {prod_id:4,productName:"Chocolade",productPrice:400},
    {prod_id:5,productName:"chaiMaxilaku",productPrice:300}];

    getproduct:ProductDetails={};

    
    addproduct()
    {
      this.product.push(this.getproduct);
       this.getproduct={};
    }

    deleteproduct(prodid?:number)
    {
      for(let index=0;index<this.product.length;index++ )
      {
        if(this.product[index].prod_id==prodid)
        {
          this.product.splice(index,1);
        }
       
        
      }
      
    }
    updateproduct()
    {
      debugger;
      for(let i=0;i<this.product.length;i++)
      {
        if(this.product[i].prod_id==this.getproduct.prod_id)
        {
      
          this.product[i]=this.getproduct;
          this.getproduct={};

        }
      }
    }
    prodno?:number;
    editproduct(i:number)
    {
      this.getproduct.prod_id=this.product[i].prod_id;
      this.getproduct.productName=this.product[i].productName;
      this.getproduct.productPrice=this.product[i].productPrice;
      this.prodno=i;
    }
   

   
  ngOnInit(): void {
  }

}
