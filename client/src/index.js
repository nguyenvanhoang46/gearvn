import React from 'react';
import ReactDOM from 'react-dom/client';
import { Provider } from 'react-redux';
import {
  RouterProvider
} from "react-router-dom";
import App from './App';
import store from './app/store';
import AuthProvider from './contexts/AuthProvider';
import './index.css';
import reportWebVitals from './reportWebVitals';
import router from './routes';
import { Context } from './contexts/cart/Context';
import {
  QueryClient,
  QueryClientProvider,
} from 'react-query'
import { ToastContainer, toast } from 'react-toastify';

const root = ReactDOM.createRoot(document.getElementById('root'));

const queryClient = new QueryClient()


root.render(
  <Provider store={store}>
    <QueryClientProvider client={queryClient}>
      <Context>
        <ToastContainer />
        <AuthProvider>
          <RouterProvider router={router} />
        </AuthProvider>
      </Context>
    </QueryClientProvider>
  </Provider>
);


// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
