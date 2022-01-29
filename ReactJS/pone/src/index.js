import React from 'react';
import ReactDOM from 'react-dom';
import createSagaMiddleware from 'redux-saga'
import { createStore, applyMiddleware } from 'redux';
import { Provider } from 'react-redux';
import { logger } from 'redux-logger'
import rootSaga from './sagas'
import reducer from './reducers'
import App from './App';
import reportWebVitals from './reportWebVitals';

const sagaMiddleware = createSagaMiddleware()
//Object using which we can access all the methods from redux-saga

const mystore = createStore(  //create the store and i am also connecting the
  //reducer with the Middleware
  reducer,
  applyMiddleware(sagaMiddleware, logger) //binding the sagamiddleware and 
  //the logger into the redux middleware
)
sagaMiddleware.run(rootSaga)
//Triggering/Executing the root saga - Async Method
//Provider is used to Integrate the store with components
ReactDOM.render(
  <Provider store={mystore}>
    <App />
  </Provider>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();