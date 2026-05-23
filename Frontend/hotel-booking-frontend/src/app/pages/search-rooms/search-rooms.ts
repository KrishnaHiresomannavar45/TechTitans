import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-search-rooms',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './search-rooms.html',
  styleUrl: './search-rooms.css'
})
export class SearchRooms {

  showRooms = false;

  searchRooms() {
    this.showRooms = true;
  }

}