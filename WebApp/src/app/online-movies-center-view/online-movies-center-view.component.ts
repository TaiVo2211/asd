import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-online-movies-center-view',
  templateUrl: './online-movies-center-view.component.html',
  styleUrls: ['./online-movies-center-view.component.scss']
})
export class OnlineMoviesCenterViewComponent implements OnInit {

  testingimage: any = 'https://ziyemusic.com/wp-content/uploads/2019/01/Image-1210-6.jpg'
  id1: any = {
    img: this.testingimage,
  }
  listclip: any = [this.id1, this.id1, this.id1];

  constructor() { }

  ngOnInit() {
  }

}
