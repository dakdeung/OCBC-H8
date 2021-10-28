import { Component } from '@angular/core';
import { Params } from './models/Params';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  isHome = true;
  isAll = false;
  isDetails = false;
  before = ""

  showFromAll(){
    this.isHome = false;
    this.isAll = false;
    this.isDetails = true;
    this.before = "all"
  }

  showFromHome(){
    this.isHome = false;
    this.isAll = false;
    this.isDetails = true;
    this.before = "all"
  }

  title = 'informationSystemCountry';
  // params:Params[]=[]

  // onInit(){
  //   this.params = [
  //     {
  //       isAll: false,
  //       isHome: true,
  //       isDetail: false,
  //       before : ""
  //     }
  //   ]
  // }

  showAll(){
    this.isHome = false;
    this.isAll = true;
    this.isDetails = false;
    this.before = ""
    // this.params.map((v,i) => {
    //   v.isAll = true;
    //   v.isHome = false;
    //   v.isDetail = false;
    //   return v;
    // })
  }

  showHome(){
    this.isHome = true;
    this.isAll = false;
    this.isDetails = false;
    this.before = ""
  //   this.params.map((v,i) => {
  //     v.isAll = false;
  //     v.isHome = true;
  //     v.isDetail = false;
  //     return v;
  //   })
  }
}
