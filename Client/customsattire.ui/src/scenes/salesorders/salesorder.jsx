import React, { useState, useEffect, useCallback } from "react";
import { Box, Button, TextField, Grid, Stack } from "@mui/material";
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
import {
  addSalesOrders,
  loadCustomers,
  loadSalesOrders,
} from "./../../redux/action";
import { Autocomplete } from "@mui/material";
import ProductDropDowns from "../../components/ProductDropDowns";

const SalesOrder = () => {
  const isNonMobile = useMediaQuery("(min-width: 600px)");
  const dispatch = useDispatch();
  const navigate = useNavigate();
  const [customerName, setcustomerName] = useState("");
  const [setSelectedCustomer] = useState(null);
  const [setQty] = useState(0);
  const [setTotalB] = useState();
  const [setDiscountA] = useState(0);
  const [setDiscountB] = useState(0);
  const [setStitchingCost] = useState(0);
  const [setGrandTotal] = useState();
  const [fabricDescription, setfabricDescription] = useState();
  const [setDue] = useState(0);
  const [inputDue, setInputDue] = useState(0);
  const [setQuantity] = useState("");
  const [setPrice] = useState("");
  const [total, setTotal] = useState("");
  const [setpricePerMeter] = useState({});
  const [setpurchaseItemwiseCost] = useState({});
  const [totalBillAmount, settotalBillAmount] = useState(0);
  const [setadvancePayment] = useState({});
  const [setduePayment] = useState({});
  const [rows, setRows] = useState([]);
  const [selectedFabrics, setSelectedFabrics] = useState(); // state variable to store selected fabrics
  const [selectedDescription, setSelectedDescription] = useState();

  const [trialDate, setTrialDate] = useState(new Date());
  const [deliveryDate, setDeliveryDate] = useState("");
  const [inputAdvance, setInputAdvance] = useState("");
  const [orderId, setOrderId] = useState("");
  const [saveButtonUsed, setSaveButtonUsed] = useState(true);
  const [cancelValue, setCancelValue] = useState("true");

  const handleSelectFabricChange = useCallback(
    (newValue, value) => {
      if (newValue !== undefined) {
        let fabricCode = newValue.fabricCode;
        let Description = newValue.description;
        setSelectedFabrics(fabricCode);
        setSelectedDescription(Description);
      }
    },
    [selectedFabrics]
  );

  const handleTrialDateChange = (event) => {
    const selectedDate = new Date(event.target.value);
    setTrialDate(selectedDate);
    setDeliveryDate("");
  };

  const handleDeliveryDateChange = (event) => {
    const selectedDate = new Date(event.target.value);
    const formattedDate = selectedDate.toISOString().slice(0, 10);
    setDeliveryDate(formattedDate);
  };

  // Modify the format of the date to yyyy-MM-dd
  const formattedTrialDate =
    trialDate instanceof Date ? trialDate.toISOString().slice(0, 10) : null;

  // Get the day after the trial date
  const minDeliveryDate = formattedTrialDate
    ? new Date(trialDate.getTime() + 24 * 60 * 60 * 1000)
        .toISOString()
        .slice(0, 10)
    : null;

  useEffect(() => {
    dispatch(loadSalesOrders());
    dispatch(loadCustomers());
    //eslint-disable-next-line react-hooks/exhaustive-deps
  }, [cancelValue, saveButtonUsed]);
  const { customers } = useSelector((state) => state.data);
  const { salesorders } = useSelector((state) => state.data);

  useEffect(() => {
    const due = totalBillAmount - inputAdvance;
    setInputDue(due);
  }, [totalBillAmount, inputAdvance]);
  useEffect(() => {
    // console.log(salesorders);
    dispatch(loadSalesOrders());
    let lastorderId = "";
    // console.log(salesorders + "hello");
    if (salesorders.length === 0) lastorderId = 1;
    else {
      for (let i = 0; i < salesorders.length; i++) {
        console.log("salesorders.length" + salesorders.length);
        const orderId = salesorders[i].billHeaderId.split("/").pop();
        // console.log("orderId" + orderId);
        // console.log("lastorerId" + lastorderId);
        if (orderId > lastorderId) {
          lastorderId = orderId;
        }
        lastorderId = parseInt(lastorderId);
        lastorderId = lastorderId;
        // console.log("lastorerId" + lastorderId);
      }
    }
    const orderId = generateOrderId(lastorderId + 1);
    console.log("generateOrderId" + orderId);
    setOrderId(orderId);
    // console.log(orderId);
    //eslint-disable-next-line react-hooks/exhaustive-deps
  }, [salesorders, cancelValue, saveButtonUsed]);

  const handleAdvChange = (event) => {
    setInputAdvance(event.target.value);
  };

  useEffect(() => {
    const due = totalBillAmount - inputAdvance;
    setInputDue(due);
  }, [totalBillAmount, inputAdvance]);

  function getTheLastSalesDetails(details) {
    const lastSaleDetail = details[0];
    const orderId = lastSaleDetail.billHeaderId;
    const parts = orderId.split("/");
    const lastOrderNumber = parseInt(parts[parts.length - 1]);
    const newOrderNumber = lastOrderNumber + 1;
    return newOrderNumber;
  }

  const calculateTotal = (rowId) => {
    const qty = parseFloat(document.getElementById(`qty${rowId}`).value);
    const price = parseFloat(document.getElementById(`price${rowId}`).value);
    const total = qty * price;
    document.getElementById(`total${rowId}`).innerText = total.toFixed(2);
    grandTotalAB(rowId);
  };

  const grandTotalA = (e, rowId) => {
    const total = parseFloat(
      document.getElementById(`total${rowId}`).innerText
    );
    const discountA = parseFloat(Math.round(e.target.value * 100) / 100);
    console.log("discountA:", discountA); // add this line
    const grandTotalA =
      Math.round((total - (total * discountA) / 100) * 100) / 100;
    document.getElementById(`grandTotalA${rowId}`).innerText =
      grandTotalA.toFixed(2);
    grandTotalAB(rowId);
    settotalBillAmount(total.toFixed(2));
  };

  const grandTotalB = (rowId) => {
    const discountB = parseFloat(
      document.getElementById(`discountB${rowId}`).value
    );
    const stitchingCost = parseFloat(
      document.getElementById(`stitchingCost${rowId}`).value
    );
    const grandTotalB = stitchingCost - (stitchingCost * discountB) / 100;
    document.getElementById(`grandTotalB${rowId}`).innerText = Math.round(
      (grandTotalB * 100) / 100
    ).toFixed(2); // round off to 2 decimal places after rounding off to the nearest integer
    grandTotalAB(rowId); // add this line
  };

  const grandTotalAB = () => {
    let total = 0;
    rows.forEach((row) => {
      const grandTotalA = parseFloat(
        document.getElementById(`grandTotalA${row.id}`).innerText
      );
      const grandTotalB = parseFloat(
        document.getElementById(`grandTotalB${row.id}`).innerText
      );
      const grandTotalAB = grandTotalA + grandTotalB;
      total += grandTotalAB;
      document.getElementById(`grandTotalAB${row.id}`).innerText =
        grandTotalAB.toFixed(2);
    });
    settotalBillAmount(total.toFixed(2));
  };

  const handleSubmit = (values) => {
    navigate("/dashboard");
    handleCancel();
  };

  const handleCustomerChange = (event, newValue) => {
    const customer = newValue;
    setcustomerName(customer);
  };

  const addRow = () => {
    const newRow = {
      id: rows.length + 1,
      desc: "",
      qty: "",
      price: "",
      total: "",
    };
    setRows([...rows, newRow]);

    // Calculate grandTotalAB for all rows
    rows.forEach((row) => {
      grandTotalAB(row.id);
    });
  };

  const handleCancel = () => {
    setcustomerName(null);
    setRows([initialRowState]);
    setInputAdvance("0");
    setInputDue("0");
    settotalBillAmount("");
    setTrialDate("");
    setDeliveryDate("");
    navigate("/salesorders");
  };

  const initialRowState = {
    id: orderId,
    fabricCode: "",
    fabricDesc: "",
    clothType: "",
    qty: 0,
    pricePerMeter: 0,
    discountA: 0,
    discountB: 0,
    formattedTrialDate: "",
    inputAdvance: "",
    inputDue: 0,
    totalBillAmount: 0,
    deliveryDate: "",
  };
  function generateOrderId(lastNumberFromDatabase) {
    // Get today's date in the format DDMMYYYY
    const today = new Date()
      .toLocaleDateString("en-GB")
      .split("/")
      .reverse()
      .join("");

    const nextNumber = lastNumberFromDatabase;

    const formattedNextNumber = "0000" + nextNumber;

    return `O/${today}/${formattedNextNumber}`;
  }

  const saveData = () => {
    setCancelValue(!cancelValue);
    setcustomerName(null);
    setRows([initialRowState]);
    setInputAdvance("0");
    setInputDue("0");
    settotalBillAmount("");
    setDeliveryDate("");
    setSaveButtonUsed(!saveButtonUsed);
    const data = rows.map((row) => ({
      billHeaderId: orderId,
      customerName: customerName
        ? `${customerName.firstName} ${customerName.lastName}`
        : "",
      fabricCodeId: selectedFabrics,
      fabricDesc: selectedDescription,
      clothType: document.getElementById(`clothType${row.id}`).value.toString(),
      qty: parseFloat(document.getElementById(`qty${row.id}`).value),
      pricePerMeter: parseFloat(
        document.getElementById(`price${row.id}`).value
      ),
      fabricDiscount: parseFloat(
        document.getElementById(`discountA${row.id}`).value
      ),
      totalPricePerMeter: parseFloat(
        document.getElementById(`grandTotalA${row.id}`).textContent
      ),
      stitchingFlag: true, // or false, depending on your needs
      totalItemwiseCost: parseFloat(
        document.getElementById(`total${row.id}`).textContent
      ),

      stitchingCost: parseFloat(
        document.getElementById(`stitchingCost${row.id}`).value
      ),
      stitchingDiscount: parseFloat(
        document.getElementById(`discountB${row.id}`).value
      ),
      purchasedItemReturnCost: "0",
      schemeFlag: "0",
      loyaltySchemeId: "0",
      redeemAmount: "0",
      advancePayment: parseFloat(inputAdvance),
      duePayment: inputDue,
      totalBillAmount: totalBillAmount,

      totalStitichingCost: parseFloat(
        document.getElementById(`grandTotalB${row.id}`).textContent
      ),
      //trialDate:
      //deliveryDate
    }));

    data.forEach((oneData) => {
      dispatch(addSalesOrders(oneData));
    });
    navigate("/salesorders");
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
              <Autocomplete
                id="customer-autocomplete"
                options={customers || []}
                getOptionLabel={(option) =>
                  option.firstName + " " + option.lastName
                }
                value={customerName || null}
                onChange={(event, newValue) =>
                  handleCustomerChange(event, newValue)
                }
                isOptionEqualToValue={(option, value) =>
                  option.name === value.name
                }
                renderInput={(params) => (
                  <TextField
                    {...params}
                    label="Customer"
                    variant="outlined"
                    sx={{
                      align: "left",
                      minWidth: 270,
                      maxWidth: 470,
                      pt: 1,
                    }}
                  />
                )}
              />
            </Box>
          </Box>
          <Box sx={{ width: 1 / 2 }}></Box>
          <Box
            align="right"
            gridTemplateColumns="repeat(3, minmax(0, 1fr))"
            sx={{ mx: "right", p: 1, mt: 1 }}
          >
            <Box align="right" name="billHeaderId" value="billHeaderId">
              OrderId: {orderId}
            </Box>
            <Button
              variant="contained"
              color="primary"
              startIcon={<AddIcon />}
              size="medium"
              onClick={addRow}
              disabled={!customerName}
            >
              Add Sales Orders
            </Button>
          </Box>
        </Box>
        <Box my={4}>
          <TableContainer component={Paper}>
            <Table sx={{ minWidth: 1200 }}>
              <TableHead>
                <TableRow>
                  <TableCell align="left" colSpan={1}>
                    SL NO
                  </TableCell>
                  <TableCell align="left" colSpan={1}>
                    Fabric Code and Description
                  </TableCell>
                  <TableCell align="left" colSpan={1}>
                    {/* Description */}
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Outfit Type
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
                    Discount%(A)
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Grand Total (A)
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Stitching Cost
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Discount%(B)
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Grand Total (B)
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Total (A+B)
                  </TableCell>
                  <TableCell align="right" colSpan={1} />
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
                      <ProductDropDowns
                        id={`fabricCode${row.id}`}
                        value={fabricDescription}
                        onChange={handleSelectFabricChange}
                      />
                    </TableCell>
                    <TableCell align="right" colSpan={1} name="fabricDesc">
                      {/* {fabricDescription} */}
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Outfit Type"
                            type="text"
                            style={{ width: 100 }}
                            id={`clothType${row.id}`}
                            name="clothType"
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Quantity"
                            type="number"
                            id={`qty${row.id}`}
                            name="qty"
                            style={{ width: 80 }}
                            onChange={(e) => {
                              const { value } = e.target;
                              setQty((prevQty) => ({
                                ...prevQty,
                                [row.id]: value,
                              }));
                              calculateTotal(row.id);
                            }}
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
                            style={{ width: 70 }}
                            id={`price${row.id}`}
                            name="pricePerMeter"
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
                            style={{ width: 100 }}
                            name="fabricDiscount"
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
                            style={{ width: 105 }}
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
                            label="Discount(B)"
                            type="number"
                            style={{ width: 105 }}
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
                    <TableCell align="right" colSpan={1}></TableCell>
                    <TableCell align="center" colSpan={1}>
                      <TextField
                        label="Trial Date"
                        type="date"
                        defaultValue={formattedTrialDate}
                        InputLabelProps={{
                          shrink: true,
                        }}
                        onChange={handleTrialDateChange}
                      />
                    </TableCell>
                  </TableRow>
                ))}
              </TableBody>
            </Table>
            <Box>
              <TableRow>
                <TableCell
                  rowSpan={2}
                  style={{ borderBottom: "none" }}
                  sx={{ width: 1 / 2, "& td": { border: 0 } }}
                />
                <TableCell sx={{ width: 1 / 4 }} colSpan={6}>
                  Total
                </TableCell>
                <TableCell
                  align="right"
                  colSpan={4}
                  onChange={(e) => setTotal(e.target.value)}
                >
                  {totalBillAmount}
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
                  {inputDue || 0}
                </TableCell>
              </TableRow>
              <TableRow>
                <TableCell sx={{ width: 1 / 4 }} colSpan={4}>
                  Delivery Date
                </TableCell>
                <TableCell colSpan={3} align="right">
                  <TextField
                    label="Delivery Date"
                    type="date"
                    defaultValue=""
                    value={deliveryDate}
                    onChange={handleDeliveryDateChange}
                    InputLabelProps={{
                      shrink: true,
                    }}
                    inputProps={{
                      min: minDeliveryDate,
                    }}
                  />
                </TableCell>
              </TableRow>
            </Box>
          </TableContainer>
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
            <Button variant="contained" startIcon={<Save />} onClick={saveData}>
              Save
            </Button>
            <Button
              variant="contained"
              endIcon={<Cancel />}
              onClick={handleCancel}
            >
              Cancel
            </Button>
          </Stack>
        </Box>
      </form>
    </Grid>
  );
};

export default SalesOrder;
