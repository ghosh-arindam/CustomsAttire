import { useState, useEffect } from "react";
import { Autocomplete } from "@mui/material";
import { TextField } from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import { loadProduct } from "../redux/action";

const ProductDropDownComponent = (props) => {
  const [selectedProduct, setSelectedProduct] = useState(null);
  const [searchTerm, setSearchTerm] = useState("");
  const { Products } = useSelector((state) => state.data);
  const dispatch = useDispatch();

  useEffect(
    () => {
      dispatch(loadProduct());
    },
    //eslint-disable-next-line react-hooks/exhaustive-deps
    []
  );

  // const handleChange = (value) => {
  //   console.log("Selected value:", value);
  // };

  const handleProductChange = (event, value) => {
    setSelectedProduct(value);
    if (typeof props.onChange === "function") {
      props.onChange(value);
    }
    console.log(value.fabricCode, value.description);
  };

  const handleSearchInputChange = (event) => {
    setSearchTerm(event.target.value);
  };

  const filteredProducts = Products?.filter((product) =>
    product.fabricCode.toLowerCase().includes(searchTerm.toLowerCase())
  );

  //const { onChange = handleChange } = props;

  return (
    <Autocomplete
      value={selectedProduct}
      onChange={handleProductChange}
      options={filteredProducts || []}
      getOptionLabel={(option) =>
        option.fabricCode + " - " + option.description
      }
      renderInput={(params) => (
        <TextField
          {...params}
          label="Fabric Code"
          variant="outlined"
          style={{ width: 300 }}
          onInput={handleSearchInputChange}
        />
      )}
    />
  );
};

export default ProductDropDownComponent;
