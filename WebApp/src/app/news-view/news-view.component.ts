import { Component, OnInit } from '@angular/core';
import { SharedService } from '../services/shared.service';
import { MenuService } from '../services/menu.service';

@Component({
  selector: 'app-news-view',
  templateUrl: './news-view.component.html',
  styleUrls: ['./news-view.component.scss']
})
export class NewsViewComponent implements OnInit {

  constructor() {
  }

  ngOnInit() {
  }
}
