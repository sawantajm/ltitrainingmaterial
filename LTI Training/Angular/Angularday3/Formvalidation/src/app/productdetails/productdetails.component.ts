import { Component, OnInit } from '@angular/core';
import { productService } from '../Services/product.service';

@Component({
  selector: 'app-productdetails',
  templateUrl: './productdetails.component.html',
  styleUrls: ['./productdetails.component.css']
})
export class ProductdetailsComponent implements OnInit {

  constructor(private pservice:productService) { }

  ngOnInit(): void {
    this.getdeatils();
  }

  prod:any=[];
  getdeatils()
  { debugger;
   this.prod= this.pservice.getproductFromService();
  }

}
