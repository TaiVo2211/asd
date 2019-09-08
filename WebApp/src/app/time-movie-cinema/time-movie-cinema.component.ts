import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-time-movie-cinema',
  templateUrl: './time-movie-cinema.component.html',
  styleUrls: ['./time-movie-cinema.component.scss']
})
export class TimeMovieCinemaComponent implements OnInit {

  listMovies = [
    {id: 1, name:'NGÔI NHÀ BƯƠM BƯỚM'},
    {id: 2, name:'BẠN HỌC CÕI ÂM'},   
    {id: 3, name:'ANH THẦY NGÔI SAO'}, 
    {id: 4, name:'ANGRY BIRDS 2'}, 
  ];
  listCinemas = [
    {id: 1, name: 'BHD Star Bitexco'},
    {id: 2, name: 'GLX - Nguyễn Du'},
    {id: 1, name: 'BHD Star Vincom Thảo Điền'},
    {id: 2, name: 'GLX - Tân Bình'},
  ];
  
  constructor() { }

  ngOnInit() {
  }

}
