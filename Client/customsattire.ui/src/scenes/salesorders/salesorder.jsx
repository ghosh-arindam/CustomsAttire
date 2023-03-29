import React, { useState, useEffect } from "react";
import {
  Box,
  Button,
  TextField,
  MenuItem,
  Grid,
  Select,
  Stack,
} from "@mui/material";
// import { tokens } from "../../theme";
import { v4 as uuidv4 } from "uuid";
import useMediaQuery from "@mui/material/useMediaQuery";
import Header from "../../components/Header";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import AddIcon from "@mui/icons-material/Add";
import Typography from "@mui/material/Typography";
import Save from "@mui/icons-material/Save";
import Cancel from "@mui/icons-material/Cancel";
import { useNavigate } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { loadCustomers } from "./../../redux/action";

const SalesOrder = () => {
  const isNonMobile = useMediaQuery("(min-width: 600px)");
  const dispatch = useDispatch();
  const navigate = useNavigate();
  const [Customer, setCustomer] = useState("");
  const [total, setTotal] = useState(0);
  // const [grandTotalA, setGrandTotalA] = useState(0);
  // const [grandTotalB, setGrandTotalB] = useState(0);
  const [totalB, setTotalB] = useState(0);
  const [discountA, setDiscountA] = useState(0);
  const [discountB, setDiscountB] = useState(0);
  const [stitchingCost, setStitchingCost] = useState(0);
  const [grandTotal, setGrandTotal] = useState(0);
  const [
    fabricDescription,
    // eslint-disable-next-line
    setfabricDescription,
  ] = useState();
  const [due, setDue] = useState(0);
  const [inputAdvance, setInputAdvance] = useState(0);
  const [inputDue, setInputDue] = useState(0);
  const [quantity, setQuantity] = useState("");
  const [price, setPrice] = useState("");

  const [rows, setRows] = useState([]);
  //const tableRef = useRef(null);

  useEffect(() => {
    //dispatch(loadSuppliers());
    dispatch(loadCustomers());
    //eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);
  const { customers } = useSelector((state) => state.data);
  const handleAdvChange = (e) => {
    const due = grandTotal - e.target.value;
    setInputAdvance(e.target.value);
    setInputDue(due);
  };

  const calculateTotal = (rowId) => {
    const qty = document.getElementById(`qty${rowId}`).value;
    const price = parseFloat(document.getElementById(`price${rowId}`).value);
    const total = qty * price;
    document.getElementById(`total${rowId}`).innerText = total.toFixed(2);
  };

  const grandTotalA = (e, rowId) => {
    const total = parseFloat(
      document.getElementById(`total${rowId}`).innerText
    );
    const discountA = parseFloat(e.target.value);
    const grandTotalA = total - (total * discountA) / 100;
    document.getElementById(`grandTotalA${rowId}`).innerText =
      grandTotalA.toFixed(2);
  };

  const grandTotalB = (rowId) => {
    const discountB = parseFloat(
      document.getElementById(`discountB${rowId}`).value
    );
    const stitchingCost = parseFloat(
      document.getElementById(`stitchingCost${rowId}`).value
    );
    const grandTotalB = stitchingCost - (stitchingCost * discountB) / 100;
    document.getElementById(`grandTotalB${rowId}`).innerText =
      grandTotalB.toFixed(2);
  };

  const grandTotalAB = (rowId) => {
    const grandTotalA = parseFloat(
      document.getElementById(`grandTotalA${rowId}`).value
    );
    const grandTotalB = parseFloat(
      document.getElementById(`grandTotalB${rowId}`).value
    );
    const grandTotalAB = grandTotalA + grandTotalB;
    document.getElementById(`grandTotalAB${rowId}`).innerText =
      grandTotalAB.toFixed(2);
  };

  const handleFabricChange = (event) => {
    console.log(event.target.value);
  };

  const handleSubmit = (values) => {
    //dispatch(addPurchaseOrders(values));
    console.log(values);
    navigate("/dashboard");
  };

  const handleCustomerChange = (e) => {
    const customer = e.target.value;
    // console.log(vendorName);
    setCustomer(customer);

    const setfabricDescription = (event) => {
      console.log(event.target.value);
    };
  };

  const handleInputChange = (event) => {
    const target = event.target;
    const name = target.name;
    const value = target.value;

    // update the corresponding state property
    switch (name) {
      case "selectedVendor":
        setCustomer(value);
        break;
      case "rows":
        setRows(value);
        break;
      case "total":
        setTotal(value);
        break;
      case "totalB":
        setTotalB(value);
        break;
      case "discountA":
        setDiscountA(value);
        break;
      case "discountB":
        setDiscountB(value);
        break;
      case "stitchingCost":
        setStitchingCost(value);
        break;
      case "grandTotal":
        setGrandTotal(value);
        break;
      case "due":
        setDue(value);
        break;
      case "inputAdvance":
        setInputAdvance(value);
        break;
      case "inputDue":
        setInputDue(value);
        break;
      case "quantity":
        setQuantity(value);
        break;
      case "price":
        setPrice(value);
        break;
      default:
        break;
    }
  };

  const addRow = () => {
    const newRow = {
      id: rows.length + 1,
      desc: "",
      qty: "",
      price: "",
      total: "0",
    };
    setRows([...rows, newRow]);
  };

  return (
    <Grid sx={{ flexGrow: 1 }} mx={4}>
      <Header title="SALES ORDER" subtitle="List of Sales Orders Made" />
      <form onSubmit={handleSubmit} autoComplete="off">
        <Box
          display="grid"
          gap="30px"
          gridTemplateColumns="repeat(3, minmax(0, 1fr))"
          sx={{
            "& > div": { gridColumn: isNonMobile ? undefined : "span 4" },
          }}
        >
          <Box sx={{ width: 1 / 2 }}>
            <Box sx={{ width: 1 / 4 }}></Box>
            <Box sx={{ mx: "left", p: 1, mt: 1 }}>
              <TextField
                align="left"
                id="outlined-select"
                select
                label="Customer"
                variant="outlined"
                onChange={handleCustomerChange}
                value={Customer || ""}
                defaultValue={"--SELECT A  CUSTOMER--"}
                name="customerName"
                //error={!!touched.supplierId && !!errors.supplierId}
                //helperText={touched.supplierId && errors.supplierId}
                sx={{
                  align: "left",
                  minWidth: 270,
                  maxWidth: 470,
                  pt: 1,
                  "& .MuiNativeSelect-select": { pt: "8.5px" },
                }}
              >
                {customers?.map((d, index) => (
                  <MenuItem
                    key={index}
                    // value={JSON.stringify({
                    //   id: d.id,
                    //   name: d.vendorname,
                    // })}
                    value={d.firstName}
                  >
                    {d.firstName + " " + d.lastName}
                  </MenuItem>
                ))}
              </TextField>
            </Box>
          </Box>
          <Box sx={{ width: 1 / 2 }}></Box>
          <Box
            align="right"
            gridTemplateColumns="repeat(3, minmax(0, 1fr))"
            sx={{ mx: "right", p: 1, mt: 1 }}
          >
            <Box align="right">OrderId:{uuidv4()}</Box>
            <Button
              variant="contained"
              color="primary"
              startIcon={<AddIcon />}
              size="medium"
              onClick={addRow}
            >
              Add Sales Orders
            </Button>
          </Box>
        </Box>
        <Box my={4}>
          <TableContainer
            component={Paper}
            // sx={{ maxwidth: "2000", maxheight: "2000", overflow: "auto" }}
          >
            <Table sx={{ minWidth: 700 }}>
              <TableHead>
                <TableRow>
                  <TableCell align="left" colSpan={1}>
                    SL NO
                  </TableCell>
                  <TableCell align="left" colSpan={1}>
                    Fabric Code
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Description
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Quantity
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Price
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Total
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Discount (A)
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Grand Total (A)
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Stitching Cost
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Discount (B)
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Grand Total (B)
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Total (A+B)
                  </TableCell>
                  <TableCell align="right" colSpan={2}>
                    Trial Date
                  </TableCell>
                </TableRow>
              </TableHead>
              <TableBody>
                {rows?.map((row, index) => (
                  <TableRow key={row.id}>
                    <TableCell colSpan={1}>{index + 1}</TableCell>
                    <TableCell colSpan={1}>
                      <Select
                        defaultValue={row.fabricCode}
                        onChange={handleFabricChange}
                      ></Select>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      {fabricDescription}
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Quantity"
                            type="number"
                            id={`qty${row.id}`}
                            name="quantityPurchased"
                            onChange={() => calculateTotal(row.id)}
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Price"
                            type="number"
                            id={`price${row.id}`}
                            name="costPrice"
                            onChange={() => calculateTotal(row.id)}
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Typography
                        id={`total${row.id}`}
                        onChange={(e) => calculateTotal(e.target.value)}
                      ></Typography>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Discount (A)"
                            type="number"
                            id={`discountA${row.id}`}
                            onChange={(e) => grandTotalA(e, row.id)}
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Typography id={`grandTotalA${row.id}`}></Typography>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Stitching Cost"
                            type="number"
                            id={`stitchingCost${row.id}`}
                            onChange={() => grandTotalB(row.id)}
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="DiscountB"
                            type="number"
                            id={`discountB${row.id}`}
                            onChange={() => grandTotalB(row.id)}
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Typography id={`grandTotalB${row.id}`}></Typography>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Typography id={`grandTotalAB${row.id}`}></Typography>
                    </TableCell>
                    <TableCell align="right" colSpan={1}></TableCell>
                    <TableCell align="center" colSpan={1}>
                      <TextField
                        align="right"
                        label="Calendar"
                        type="date"
                        defaultValue={new Date()}
                        InputLabelProps={{
                          shrink: true,
                        }}
                      />
                    </TableCell>
                  </TableRow>
                ))}
                {/* <TableRow>
                  <TableCell rowSpan={3} />
                  <TableCell colSpan={12}>Grand Total</TableCell>
                  <TableCell align="right" colSpan={2} name="totalCostPrice">
                    {grandTotal}
                  </TableCell>
                </TableRow> */}
              </TableBody>
            </Table>
          </TableContainer>
          <Box>
            <TableRow>
              <TableCell
                rowSpan={2}
                style={{ borderBottom: "none" }}
                sx={{ width: 1 / 2, "& td": { border: 0 } }}
              />
              <TableCell sx={{ width: 1 / 4 }} colSpan={4}>
                Total
              </TableCell>
              <TableCell align="right" colSpan={2}>
                {grandTotal}
              </TableCell>
            </TableRow>
            <TableRow>
              <TableCell sx={{ width: 1 / 4 }} colSpan={4}>
                Advance
              </TableCell>
              <TableCell colSpan={4}>
                <TextField
                  label="Advance"
                  value={inputAdvance}
                  name="paymentdone"
                  onChange={handleAdvChange}
                  sx={{
                    align: "right",
                    minWidth: 270,
                    maxWidth: 470,
                    pt: 1,
                    // "& .MuiNativeSelect-select": { pt: "8.5px" },
                  }}
                ></TextField>
              </TableCell>
            </TableRow>
            <TableRow>
              <TableCell
                rowSpan={2}
                style={{ borderBottom: "none" }}
                sx={{ width: 1 / 2, "& td": { border: 0 } }}
              />
              <TableCell sx={{ width: 1 / 4 }} colSpan={4}>
                Total Due
              </TableCell>
              <TableCell align="right" colSpan={3}>
                {inputDue}
              </TableCell>
            </TableRow>
            <TableRow>
              <TableCell sx={{ width: 1 / 4 }} colSpan={4}>
                Delivery Date
              </TableCell>
              <TableCell colSpan={3} align="right">
                <TextField
                  label="Calendar"
                  type="date"
                  defaultValue={new Date()}
                  InputLabelProps={{
                    shrink: true,
                  }}
                />
              </TableCell>
            </TableRow>
          </Box>
          <Box sx={{ width: 1 / 4 }} my={4}></Box>
          <Stack
            direction="row"
            spacing={2}
            sx={{ width: 1 / 2 }}
            mx={1}
            display="flex"
            justifyContent="end"
            mt="20px"
          >
            <Button
              variant="contained"
              startIcon={<Save />}
              onClick={handleInputChange}
            >
              Save
            </Button>
            <Button variant="contained" endIcon={<Cancel />}>
              Cancel
            </Button>
          </Stack>
        </Box>
      </form>
    </Grid>
  );
};

export default SalesOrder;
