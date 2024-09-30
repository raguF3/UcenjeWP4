import { Button, Col, Form, Row} from 'react-bootstrap';
import { Link, useNavigate, useParams } from 'react-router-dom';
import { useEffect, useState } from 'react';
import Service from '../../services/GrupaService';
import SmjerService from '../../services/SmjerService';
import { RoutesNames } from '../../constants';


export default function GrupePromjena() {
  const navigate = useNavigate();
  const routeParams = useParams();

  const [smjerovi, setSmjerovi] = useState([]);
  const [smjerSifra, setSmjerSifra] = useState(0);

  const [grupa, setGrupa] = useState({});

  async function dohvatiSmjerove(){
    const odgovor = await SmjerService.get();
    setSmjerovi(odgovor);
  }

  async function dohvatiGrupa() {
    const odgovor = await Service.getBySifra(routeParams.sifra);
    if(odgovor.greska){
      alert(odgovor.poruka);
      return;
  }
    let grupa = odgovor.poruka;
    setGrupa(grupa);
    setSmjerSifra(grupa.smjerSifra); 
  }

  async function dohvatiInicijalnePodatke() {
    await dohvatiSmjerove();
    await dohvatiGrupa();
  }


  useEffect(()=>{
    dohvatiInicijalnePodatke();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  },[]);

  async function promjena(e){
    const odgovor = await Service.promjena(routeParams.sifra,e);
    if(odgovor.greska){
        alert(odgovor.poruka);
        return;
    }
    navigate(RoutesNames.GRUPA_PREGLED);
}

  function obradiSubmit(e) {
    e.preventDefault();

    const podaci = new FormData(e.target);


    promjena({
      naziv: podaci.get('naziv'),
      smjerSifra: parseInt(smjerSifra),
      predavac: podaci.get('predavac'),
      maksimalnopolaznika: parseInt(podaci.get('maksimalnopolaznika'))
    });
  }

  return (
      <>
      Mjenjanje podataka grupe
      
      <Form onSubmit={obradiSubmit}>
          <Form.Group controlId="naziv">
              <Form.Label>Naziv</Form.Label>
              <Form.Control type="text" name="naziv" required defaultValue={grupa.naziv}/>
          </Form.Group>

          <Form.Group className='mb-3' controlId='smjer'>
            <Form.Label>Smjer</Form.Label>
            <Form.Select
            value={smjerSifra}
            onChange={(e)=>{setSmjerSifra(e.target.value)}}
            >
            {smjerovi && smjerovi.map((s,index)=>(
              <option key={index} value={s.sifra}>
                {s.naziv}
              </option>
            ))}
            </Form.Select>
          </Form.Group>

          <Form.Group controlId="predavac">
              <Form.Label>Predavač</Form.Label>
              <Form.Control type="text" name="predavac" required defaultValue={grupa.predavac}/>
          </Form.Group>

          <Form.Group controlId="maksimalnopolaznika">
              <Form.Label>Maksimalno polaznika</Form.Label>
              <Form.Control type="number" name="maksimalnopolaznika" min={5} max={30} defaultValue={grupa.maksimalnoPolaznika}/>
          </Form.Group>


          <hr />
          <Row>
              <Col xs={6} sm={6} md={3} lg={6} xl={6} xxl={6}>
              <Link to={RoutesNames.GRUPA_PREGLED}
              className="btn btn-danger siroko">
              Odustani
              </Link>
              </Col>
              <Col xs={6} sm={6} md={9} lg={6} xl={6} xxl={6}>
              <Button variant="primary" type="submit" className="siroko">
                  Promjeni grupu
              </Button>
              </Col>
          </Row>
      </Form>
  </>
  );
}
