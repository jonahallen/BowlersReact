import React, { useState } from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './Bowler/BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="Barbara  and David's Bowling League" />
      <BowlerList />
    </div>
  );
}

export default App;
