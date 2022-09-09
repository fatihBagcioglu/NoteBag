import { Container, Row, Col, Button, ListGroup, Form } from 'react-bootstrap';
import './App.css';
import NbNavbar from './components/NbNavbar';
import axios from 'axios';
import { useEffect, useState } from 'react';

function App() {
  const [notes, setNotes] = useState([])

  // App bileşeni ilk render olduğunda (mount)
  useEffect(function () {
    axios.get("https://localhost:7156/api/Notes")
      .then(function (response) {
        setNotes(response.data);
      });
  }, []);


  return (
    <div className="App">
      <NbNavbar />
      <Container fluid className="mt-4">
        <Row>
          <Col sm={4} md={3}><Button>Yeni</Button>

            <ListGroup className="mt-3 mb-3">
              {notes.map((note, index) =>
                <ListGroup.Item action key={note.id}>
                  {note.title}
                </ListGroup.Item>)}

            </ListGroup>

          </Col>
          <Col sm={8} md={9}>
            <Form>
              <Form.Group className="mb-2">
                <Form.Control type="text" placeholder="Title"></Form.Control>
              </Form.Group>
              <Form.Group className="mb-3">
                <Form.Control as="textarea" placeholder="Content" rows={10}></Form.Control>
              </Form.Group>
            </Form>
            <div>
              <Button variant="primary" className="me-2">Kaydet</Button>
              <Button variant="danger">Sil</Button>
            </div>
          </Col>
        </Row>
      </Container>
    </div >
  );
}

export default App;
