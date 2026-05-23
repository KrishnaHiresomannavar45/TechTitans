import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    loadComponent: () =>
      import('./pages/home/home').then(m => m.Home)
  },
  {
    path: 'search',
    loadComponent: () =>
      import('./pages/search-rooms/search-rooms').then(m => m.SearchRooms)
  },
  {
    path: 'room-details',
    loadComponent: () =>
      import('./pages/room-details/room-details').then(m => m.RoomDetails)
  },
  {
    path: 'booking',
    loadComponent: () =>
      import('./pages/booking-form/booking-form').then(m => m.BookingForm)
  },
  {
    path: 'confirmation',
    loadComponent: () =>
      import('./pages/booking-confirmation/booking-confirmation').then(m => m.BookingConfirmation)
  }
];