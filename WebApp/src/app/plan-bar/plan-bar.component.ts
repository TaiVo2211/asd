import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BsModalRef, BsModalService } from 'ngx-bootstrap';
import { MenuService } from '../services/menu.service';
import { SharedService } from '../services/shared.service';

@Component({
  selector: 'app-plan-bar',
  templateUrl: './plan-bar.component.html',
  styleUrls: ['./plan-bar.component.scss']
})
export class PlanbarComponent implements OnInit {

  listMenus: any;
  isAdmin: boolean;

  constructor(private modalService: BsModalService,
    private menuService: MenuService,
    private sharedService: SharedService,
    private router: Router) { }


  ngOnInit() {
  }


}
