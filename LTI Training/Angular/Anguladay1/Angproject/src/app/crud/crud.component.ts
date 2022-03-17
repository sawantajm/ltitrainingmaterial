import { Component, OnInit } from '@angular/core';
import { Department } from '../Module/department.model';

@Component({
  selector: 'app-crud',
  templateUrl: './crud.component.html',
  styleUrls: ['./crud.component.css']
})
export class CrudComponent implements OnInit 
{


  constructor() { 
    
  }
    dept:Department[]=[
    {did:101,dname:"Ux",location:"Chennai"},
    {did:102,dname:"finance",location:"mumbai"},
    {did:103,dname:"AI",location:"Mumbai"},
    {did:104,dname:"HR",location:"chennai"}];

    //creating Department object

getdeptinfo:Department={};
    adddept()
    {
       this.dept.push(this.getdeptinfo);
       this.getdeptinfo={};
    }

    deletedept(deptid?:number)
    {
        for(let index=0;index<this.dept.length;index++)
        { 
          if(this.dept[index].did==deptid)
          {
            this.dept.splice(index,1);
          }
        }
    }
    

    
indexvalue?:number;
editdept(i:number)
{
  this.getdeptinfo.did=this.dept[i].did;
  this.getdeptinfo.dname=this.dept[i].dname;
  this.getdeptinfo.location=this.dept[i].location;
  this.indexvalue=i;
}
updateedept()
{
  for(let i=0;i<this.dept.length;i++)
  {
    if(this.dept[i].did=this.getdeptinfo.did)
    {
      this.dept[i]=this.getdeptinfo;
      this.getdeptinfo={};
    }
  }
}





      ngOnInit(): void {
      }


    }
