import { Component, OnInit } from '@angular/core';
import { SharedService } from '../services/shared.service';

@Component({
  selector: 'app-main-view',
  templateUrl: './main-view.component.html',
  styleUrls: ['./main-view.component.scss']
})
export class MainViewComponent implements OnInit {

  imageUrl: string = "http://localhost:59239/Images/invoker_vert.jpg";
  constructor(private sharedService: SharedService) {
    this.sharedService.action.subscribe(result => {
      this.text += result;
    })
  }

  text: number = 0;

  ngOnInit() {
  }


}
