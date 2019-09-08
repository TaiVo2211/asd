import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-booking-ticket',
  templateUrl: './booking-ticket.component.html',
  styleUrls: ['./booking-ticket.component.scss']
})
export class BookingTicketComponent implements OnInit {

  listCombo: any = [
    {
      id: 0,
      imgUrl:"https://media.ifind.vn/data/images/media/3d4-1535013677796.jpg",
      comboname:"Bắp Nước",
      price:"40.000vnđ"
    },
  ]

  listTicket: any = [
    {
      id: 0,
      tickettype:"Vé 2D",
      price:"80.000vnđ"
    },
  ]

  constructor() { }

  ngOnInit() {
  }

}
