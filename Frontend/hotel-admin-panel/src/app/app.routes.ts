import { Routes } from '@angular/router';

import { Dashboard } from './components/dashboard/dashboard';
import { ManageBookings } from './components/manage-bookings/manage-bookings';
import { ManageRooms } from './components/manage-rooms/manage-rooms';
export const routes: Routes = [
  {
    path: '',
    redirectTo: 'dashboard',
    pathMatch: 'full',
  },

  {
    path: 'dashboard',
    component: Dashboard,
  },

  {
    path: 'rooms',
    component: ManageRooms,
  },

  {
    path: 'bookings',
    component: ManageBookings,
  },
];
