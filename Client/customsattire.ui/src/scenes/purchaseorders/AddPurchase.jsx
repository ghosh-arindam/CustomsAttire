import { Box, Button, TextField } from "@mui/material";
import { Formik } from "formik";
import * as yup from "yup";
import useMediaQuery from "@mui/material/useMediaQuery";
import Header from "../../components/Header";
import { useNavigate } from "react-router-dom";
import { useDispatch } from "react-redux";
// import { addPurchases } from "./../../redux/action";

const AddPurchase = () => {
    const isNonMobile = useMediaQuery("(min-width: 600px)");
    const navigate = useNavigate();
    const dispatch = useDispatch();

    const handleFormSubmit = (values) => {
        console.log(values);
        // dispatch(addPurchases);
        navigate("/purchase");
    };

    return (
        <Box m="20px">
			<Header title="CREATE PURCHASE" subtitle="Create a new Purchase" />

			<Formik
				onSubmit={handleFormSubmit}
				initialValues={initialValues}
			>
				{({
					values,
					errors,
					touched,
					handleBlur,
					handleChange,
					handleSubmit,
				}) => (
					<form onSubmit={handleSubmit} autoComplete="off">
						<Box
							display="grid"
							gap="30px"
							gridTemplateColumns="repeat(4, minmax(0, 1fr))"
							sx={{
								"& > div": { gridColumn: isNonMobile ? undefined : "span 4" },
							}}
						>
							<TextField
									fullWidth
									variant="filled"
									type="text"
									label="Employee ID"
									onBlur={handleBlur}
									onChange={handleChange}
									value={values.employeeid}
									name="employeeid"
									error={!!touched.title && !!errors.title}
									helperText={touched.title && errors.title}
									sx={{ gridColumn: "span 0.5" }}
								/>
							<TextField
									fullWidth
									variant="filled"
									type="text"
									label="Fabric Code"
									onBlur={handleBlur}
									onChange={handleChange}
									value={values.fabriccode}
									name="fabriccode"
									error={!!touched.title && !!errors.title}
									helperText={touched.title && errors.title}
									sx={{ gridColumn: "span 0.5" }}
								/>
							<TextField
									fullWidth
									variant="filled"
									type="text"
									label="Supplier ID"
									onBlur={handleBlur}
									onChange={handleChange}
									value={values.supplierid}
									name="supplierid"
									error={!!touched.title && !!errors.title}
									helperText={touched.title && errors.title}
									sx={{ gridColumn: "span 0.5" }}
								/>
							<TextField
									fullWidth
									variant="filled"
									type="text"
									label="Quantity"
									onBlur={handleBlur}
									onChange={handleChange}
									value={values.quantity}
									name="quantity"
									error={!!touched.title && !!errors.title}
									helperText={touched.title && errors.title}
									sx={{ gridColumn: "span 0.5" }}
								/>
							<TextField
									fullWidth
									variant="filled"
									type="text"
									label="Cost Per Meter"
									onBlur={handleBlur}
									onChange={handleChange}
									value={values.costpm}
									name="costpm"
									error={!!touched.title && !!errors.title}
									helperText={touched.title && errors.title}
									sx={{ gridColumn: "span 0.5" }}
								/>
							<TextField
									fullWidth
									variant="filled"
									type="date"
									label="Due Payment"
									onBlur={handleBlur}
									onChange={handleChange}
									value={values.duepayment}
									name="duepayment"
									defaultValue={
										new Date().getFullYear() +
											"-" +
											("0" + new Date().getMonth() + 1).slice(-2) +
											"-" +
											("0" + new Date().getDate()).slice(-2)
									}
									sx={{ gridColumn: "span 1" }}
									InputLabelProps={{
										shrink: true,
									}}
									error={!!touched.title && !!errors.title}
									helperText={touched.title && errors.title}
								/>
							<TextField
									fullWidth
									variant="filled"
									type="singleselect"
									label="Payment Mode"
									onBlur={handleBlur}
									onChange={handleChange}
									value={values.paymentmode}
									name="paymentmode"
									error={!!touched.title && !!errors.title}
									helperText={touched.title && errors.title}
									sx={{ gridColumn: "span 0.5" }}
								/>
						</Box>
						<Box display="flex" justifyContent="end" mt="20px">
							<Button type="submit" color="secondary" variant="contained">
								Add New Purchase
							</Button>
						</Box>
					</form>
				)}
			</Formik>
        </Box>
    );
};

const initialValues = {
	title: "",
}

export default AddPurchase;
