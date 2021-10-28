import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Country } from 'src/app/models/Country';

@Component({
  selector: 'app-all-countries-component',
  templateUrl: './all-countries-component.component.html',
  styleUrls: ['./all-countries-component.component.css']
})
export class AllCountriesComponentComponent implements OnInit {

  country:Country[]=[]
  @Output() itemEvent = new EventEmitter<number>();
  constructor() { }

  ngOnInit(): void {

    this.country = [
      {
        name: "UNITED STATED",
        capital: "Washington DC",
        area: 95251039,
        population:10923920,
        gdp:16982382,
        currency:"United States Dollar"
      },
      {
        name: "CHINA",
        capital: "Beijing",
        area: 95251039,
        population:10923920,
        gdp:16982382,
        currency:"United States Dollar"
      },
      {
        name: "Japan",
        capital: "Tokyo",
        area: 95251039,
        population:10923920,
        gdp:16982382,
        currency:"United States Dollar"
      },
      {
        name: "Russia",
        capital: "Moscow",
        area: 95251039,
        population:10923920,
        gdp:16982382,
        currency:"United States Dollar"
      },
      {
        name: "Canada",
        capital: "Ottawa",
        area: 95251039,
        population:10923920,
        gdp:16982382,
        currency:"United States Dollar"
      },
    ]
  }

  onCardClick(){
    this.itemEvent.emit();
  }
  // showDetail(){
  //   this.param.map((v,i) => {
  //     v.isAll = false;
  //     v.isHome = false;
  //     v.isDetail = true;
  //     v.before = "home";
  //     return v;
  //   })
  // }

}
