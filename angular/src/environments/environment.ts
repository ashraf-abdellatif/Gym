import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Gym',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44322',
    redirectUri: baseUrl,
    clientId: 'Gym_App',
    responseType: 'code',
    scope: 'offline_access Gym',
  },
  apis: {
    default: {
      url: 'https://localhost:44391',
      rootNamespace: 'Fecra.Gym',
    },
  },
} as Environment;
