import { useEffect, useState } from 'react';
import { BowlingLeague } from '../types/BowlingLeague';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<BowlingLeague[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5271/BowlingLeague');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  const filteredBowlerData = bowlerData.filter(
    (b) => b.teamName === 'Marlins' || b.teamName === 'Sharks',
  );

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {filteredBowlerData.map((b) => (
            <tr key={b.bowlerId}>
              <td>
                {b.bowlerLastName}, {b.bowlerFirstName}
                {b.bowlerMiddleInit && `, ${b.bowlerMiddleInit}`}
              </td>
              <td>{b.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
