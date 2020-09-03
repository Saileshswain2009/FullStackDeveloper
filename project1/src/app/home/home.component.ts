import { Component, OnInit } from '@angular/core';
import {FormsModule} from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  title='';
  video:string='please subscribe';
  like:string='share with your friends';
  firstName:string='Amit kumar';
  lastName:string="Sweta bastia";
  istext:string='text';

  isHidden:boolean=false;
  checkProperty : string = 'SaileshTechnical';
  
  texts:string="";
  isActive:boolean=false;
  isDis:boolean=true;

  multiCssClasses:string='colorChange bgColor';

  singleCssChange:boolean=true;

  inLineColor:boolean=false;

  fontWeight:boolean=true;
  fontWeight2:boolean=false;

  myfun(event){
    console.log(event.target.value);
    
  }
  // getEmail(email){
  //   console.log(email);
    
  // }
  email="Swagat@Technical.com";
  getEmail(){
    console.log(this.email);
  }

  cv={
    name:"Sailesh swain",
    age: 27,
    boards: 66.89,
    salary: 12500,
    born: new Date(1992,0,3)
  }

  multiCssClass={
    'colorChange':true,
    'bgColor':false,
    'singleCssColorChange':true
  }

  inLineStyleCss={
    'color':'red',
    'backgroundColor':'yellow'
  }

  developerName:string="SaileshDeveloper"
  constructor() { }

  ngOnInit(): void {
  }

}
