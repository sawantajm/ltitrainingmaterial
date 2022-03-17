import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pagenotfound',
  template: '<p> 404:  Page Not Found </p>',
  styles: ['p{font-size:30px;color:black}']
})
export class PagenotfoundComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
