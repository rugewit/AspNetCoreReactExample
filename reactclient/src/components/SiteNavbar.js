import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';

function SiteNavbar(props) {
  return (
    <>
      <Navbar bg="light" variant="light">
        <Container>
          <Navbar.Brand href="#home">{props.leftText}</Navbar.Brand>
          <Nav className="ms-auto">
            <button class='btn btn-dark'><i class="bi bi-person-plus me-1"></i> Sign up</button>
            <button class='btn btn-dark ms-4'><i class="bi bi-person me-1"></i> Sign in</button>
          </Nav>
        </Container>
      </Navbar>
    </>
  );
}

export default SiteNavbar
