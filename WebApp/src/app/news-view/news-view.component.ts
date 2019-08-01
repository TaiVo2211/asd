import { Component, OnInit } from '@angular/core';
import { SharedService } from '../services/shared.service';
import { MenuService } from '../services/menu.service';

@Component({
  selector: 'app-news-view',
  templateUrl: './news-view.component.html',
  styleUrls: ['./news-view.component.scss']
})
export class NewsViewComponent implements OnInit {

  list: any;

  listABC: any = [
    {
      name: "Lucifer",
      age: 13,
    }, {
      name: "Tai",
      age: 11,
    }, {
      name: "Phat",
      age: 13,
    }
  ]

  constructor(private sharedService: SharedService, private menuService: MenuService) {
    this.sharedService.action.subscribe(result => {
      this.getData(2);
    })
  }

  text: string = "";

  ngOnInit() {
    this.getData(1);
    console.log(this.listABC);
  }

  getData(query: number) {
    this.menuService.GetData(query).subscribe(result => {
      this.list = result;
      this.list.forEach(element => {
        element.ImgUrl = `http://localhost:59239/Images/${element.imgName}`
      });
    });
  }
}
