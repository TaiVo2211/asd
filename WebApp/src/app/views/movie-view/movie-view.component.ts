import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-movie-view',
  templateUrl: './movie-view.component.html',
  styleUrls: ['./movie-view.component.scss']
})
export class MovieViewComponent implements OnInit {
  @Input("data") movie: any;

  constructor() { }

  ngOnInit() {
  }

}
