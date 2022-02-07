import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {
  title: string;
  constructor() {
    this.title='';
   }

  ngOnInit(): void {
    this.title = 'User details'
  }

}
